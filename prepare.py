#!/usr/bin/env  python3
# *-* encoding=utf8 *-*

import os
import shutil

if os.path.exists("send"):
    shutil.rmtree("send")
os.mkdir("send")

for dir in os.listdir("src"):
    path = os.path.join("src", dir)
    if not os.path.isdir(path):
        continue
    os.mkdir(os.path.join("send", dir))
    files = []
    for file in os.listdir(path):
        name = file.split('.')[0]
        if '-' in name and name not in files:
            files.append(name)
    for name in files:
        data = "---- SPEC ----\n\n"
        file = open(os.path.join(path, name+".ads"), 'r')
        data += file.read()
        file.close()
        file = open(os.path.join(path, name+".adb"), 'r')
        data += '\n\n---- BODY ---- \n\n' + file.read()
        file.close()
        file = open(os.path.join("send", dir, name+".ada"), 'w')
        file.write(data)
        file.close()
