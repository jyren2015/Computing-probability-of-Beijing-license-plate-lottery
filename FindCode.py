#!/usr/bin/env python
# -*- coding:utf-8 -*-
# @Time  : 2019/11/7 16:45
# @Author: jryen2015
# @File  : FindCode.py

"""
find the all numbers of your code
"""

num = 1
total_number = 0
while num < 172:  # the number of the data files
    str1 = str(num).zfill(4)
    str2 = "bjPersonCommonApplyNumber201905" + "_" + str1 + ".csv"
    f = open(str2, "r", encoding="utf-8")
    s = f.readline()
    j = 0
    while s:
        j = j + 1
        if s.__contains__("xxxxxxxxxx"):  # your code
            print("第" + str1 + "个文件")
            print(s)
        s = f.readline()
    f.close()
    num = num + 1
    total_number = total_number + j
print("total_number:%d" % total_number)
