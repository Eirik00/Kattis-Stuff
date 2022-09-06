x = input()
el = 0;
for i in range(0, len(x)):
    if x[i] == "e":
        el += 1
out = "h"
for i in range(0, el*2):
    out += "e"
print(out + "y")
