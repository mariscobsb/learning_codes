#########Goal: this code prints N[0 to 99] the x number and it returns x= x/2 every for range

x = float(input())

for i in range(0,100):

   print('N[' + str(i) + '] = ' + str(format(x, '.4f')))

   x /= 2
