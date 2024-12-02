with open('InputData.txt', 'r') as data:
    lines = data.readlines()

x = 0
y = 0
z = 0
a = 0
i = 0

listLeft = []
listRight = []

for data in lines:
    splitResult = data.split(" ",1)
    listLeft.append(splitResult[0])
    listRight.append(splitResult[1])

listLeft = sorted(listLeft)
listRight = sorted(listRight)
for data in listLeft:
    print(x)
    z = int(listLeft[i].strip()) - int(listRight[i].strip())
    if(z < 0):
        z = z * (-1)
    a = a + z

    i = i+1
print(a)