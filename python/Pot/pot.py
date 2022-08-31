rep = int(input())
summ = 0
for y in range(0, rep):
    x = int(input())
    summ += (x//10)**int(repr(x)[-1])
print(summ)
