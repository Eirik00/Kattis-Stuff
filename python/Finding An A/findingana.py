x = input()
n = ""
founda = False
for letter in x:
    if letter == "a" and founda == False:
        founda = True
    if founda:
        n+=letter
print(n)
