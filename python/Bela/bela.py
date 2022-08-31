domin = [11, 4, 3, 20, 10, 14, 0, 0]
ntdom = [11, 4, 3, 2, 10, 0, 0, 0]
order = ["A", "K", "Q", "J", "T", "9", "8", "7"]

fir = input().split(" ")
points = 0
for x in range(0, int(fir[0])*4):
    y = input()
    if y[1] == fir[1]:
        points += domin[order.index(y[0])]
    else:
        points += ntdom[order.index(y[0])]
print(points)
