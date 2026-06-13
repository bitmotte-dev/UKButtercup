import os

p = os.getcwd()

for root, dirs, files in os.walk(p):
    for n in files:
        if(n.endswith(".cs") or n.endswith(".sh") or n.endswith(".gitignore") or n.endswith(".sln") or n.endswith(".csproj") or n.endswith(".json") or n.endswith(".txt")):
            fp = os.path.join(root, n)

            with open(fp, "r", errors="ignore") as f:
                textToReplace = f.read()
            
            textToReplace = textToReplace.replace("Template","Template")

            with open(fp, "w", errors="ignore") as f:
                f.write(textToReplace)
            
            newFp = fp.replace("Template", "Template")
            os.rename(fp, newFp)