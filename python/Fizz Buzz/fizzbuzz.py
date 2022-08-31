x = input().split(" ")
fz = int(x[0])
bz = int(x[1])
out = ""
for i in range(1, int(x[2])+1):
    out = ""
    if (i/fz).is_integer():
        out += "Fizz"
    if (i/bz).is_integer():
        out += "Buzz"

    if out == "":
        out = i
    print(out)
