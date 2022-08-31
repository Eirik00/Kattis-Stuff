x = int(input())
xy = 0

for i in range(0, x):
    y = input()
    y = y.split(" ")
    xy += float(y[0])*float(y[1])

print(xy)
