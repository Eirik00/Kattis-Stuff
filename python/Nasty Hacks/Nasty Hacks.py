rep = int(input())
for x in range(0, rep):
    advert = input()
    x1 = int(advert.split(" ")[0])
    x2 = int(advert.split(" ")[1])-int(advert.split(" ")[2])
    if x1 > x2:
        print("do not advertise")
    elif x1 < x2:
        print("advertise")
    else:
        print("does not matter")
