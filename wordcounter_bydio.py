##########código para contar palavras, testado num arquivo txt para AWS
###

###mrjob.conf
#runners:
# emr:
#  aws_access_key_id: {your_key_id}
#  aws_secret_access_key: {your_secret_access_key}
 # ec2_key_pair: {KEY}
#  ec2_key_pair_file: ~/.ssh/{KEY}.pem
#  region: us-west-2
#  ssh_tunnel: true
#  num_core_instances: 3


from mrjob.job import MRJob
from mrjob.step import MRStep
import re

REGEX_ONLY_WORDS = "[\w']+"

class MRDataMining(MRJob):

    def steps(self):
        return [
            MRStep(mapper = self.mapper_get_words, reducer = self.reducer_count_words),
            MRStep(mapper = self.mapper_make_counts_key, reducer = self.reducer_output_words)
        ]

    def mapper_get_words(self, _, line):
        words = re.findall(REGEX_ONLY_WORDS, line)
        for word in words:
            yield word.lower(), 1

    def reducer_count_words(self, word, values):
        yield word, sum(values)

    def mapper_make_counts_key(self, word, count):
        yield '%04d'%int(count), word

    def reducer_output_words(self, count, words):
        for word in words:
            yield count, word

if __name__ == '__main__':
    MRDataMining.run()
