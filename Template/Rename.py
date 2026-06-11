with open("sample.txt", "r") as file:
    text = file.read()

newText = text
newText = newText.replace("file","bees")

with open("sample.txt", "w") as file:
    file.write(newText)

print("done ! ! !")