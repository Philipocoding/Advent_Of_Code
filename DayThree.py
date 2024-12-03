import re

with open('DayThreeData.txt', 'r') as file:
    lines = file.readlines()

pattern = r"mul\((\d{1,3}),(\d{1,3})\)"

total = 0

for LineData in lines:
    matches = re.findall(pattern, Linedata)
    for x, y in matches:
        total += int(x) * int(y)

print(total)
