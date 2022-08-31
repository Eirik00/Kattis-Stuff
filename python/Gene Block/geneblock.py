rep = int(input())
for x in range(0, rep):
    y = int(input())
    tot = 0
    while True:
        if y < 7:
            tot = -1
            break
        if repr(y)[-1] == "7":
            y -= y
            tot += 1
        elif y-7 >= 0:
            tot +=1
            y-=7
        if y <= 0:
            break
    print(tot)
