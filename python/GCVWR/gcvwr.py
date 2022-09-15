x = input().split(" ")
out = int(x[0])-int(x[1])
out = out-(out*0.1)

y = input().split(" ")
for num in y:
    out -= int(num)
print(int(out))
