seedCost = float(input())
num = int(input())
x = 0
for b in range(0, num):
    y = input()
    x+=float(y.split(" ")[0])*float(y.split(" ")[1])
print(x*seedCost)
