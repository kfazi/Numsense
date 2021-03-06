﻿module Ploeh.Numsense.SimplifiedChineseExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                    "零",          0)>]
[<InlineData(                                   " 零",          0)>]
[<InlineData(                                   "零 ",          0)>]
[<InlineData(                                "  零  ",          0)>]
[<InlineData(                                 " 零\t",          0)>]
[<InlineData(                                    "一",          1)>]
[<InlineData(                                    "二",          2)>]
[<InlineData(                                   " 两",          2)>]
[<InlineData(                                    "三",          3)>]
[<InlineData(                                  "三  ",          3)>]
[<InlineData(                                    "四",          4)>]
[<InlineData(                                 "  四 ",          4)>]
[<InlineData(                                    "五",          5)>]
[<InlineData(                                    "六",          6)>]
[<InlineData(                                "  六  ",          6)>]
[<InlineData(                                    "七",          7)>]
[<InlineData(                                "    七",          7)>]
[<InlineData(                                    "八",          8)>]
[<InlineData(                                    "九",          9)>]
[<InlineData(                                  "九  ",          9)>]
[<InlineData(                                    "十",         10)>]
[<InlineData(                                  "十一",         11)>]
[<InlineData(                                  "十二",         12)>]
[<InlineData(                                  "十三",         13)>]
[<InlineData(                                  "十四",         14)>]
[<InlineData(                                  "十五",         15)>]
[<InlineData(                                  "十六",         16)>]
[<InlineData(                                  "十七",         17)>]
[<InlineData(                                  "十八",         18)>]
[<InlineData(                                  "十九",         19)>]
[<InlineData(                                  "二十",         20)>]
[<InlineData(                                "二十一",         21)>]
[<InlineData(                                  "三十",         30)>]
[<InlineData(                                "三十四",         34)>]
[<InlineData(                                "三十八",         38)>]
[<InlineData(                                  "四十",         40)>]
[<InlineData(                                "四十一",         41)>]
[<InlineData(                                "四十四",         44)>]
[<InlineData(                                  "五十",         50)>]
[<InlineData(                                "五十七",         57)>]
[<InlineData(                                  "六十",         60)>]
[<InlineData(                                "六十五",         65)>]
[<InlineData(                                  "七十",         70)>]
[<InlineData(                                "七十七",         77)>]
[<InlineData(                                "七十九",         79)>]
[<InlineData(                                  "八十",         80)>]
[<InlineData(                                "八十六",         86)>]
[<InlineData(                                  "九十",         90)>]
[<InlineData(                                "九十三",         93)>]
[<InlineData(                                  "一百",        100)>]
[<InlineData(                              "一百零一",        101)>]
[<InlineData(                                  "两百",        200)>]
[<InlineData(                            "两百三十七",        237)>]
[<InlineData(                            "三百七十五",        375)>]
[<InlineData(                              "四百九十",        490)>]
[<InlineData(                            "五百六十三",        563)>]
[<InlineData(                            "六百一十八",        618)>]
[<InlineData(                            "七百七十七",        777)>]
[<InlineData(                              "八百零五",        805)>]
[<InlineData(                              "八百零六",        806)>]
[<InlineData(                              "八百零七",        807)>]
[<InlineData(                            "九百五十九",        959)>]
[<InlineData(                                  "一千",       1000)>]
[<InlineData(                              "一千零一",       1001)>]
[<InlineData(                              "一千零二",       1002)>]
[<InlineData(                            "一千六十四",       1064)>]
[<InlineData(                                  "两千",       2000)>]
[<InlineData(                        "八千七百二十一",       8721)>]
[<InlineData(                        "九千一百二十三",       9123)>]
[<InlineData(                                  "一万",      10000)>]
[<InlineData(                        "一万零一百零一",      10101)>]
[<InlineData(                        "一万零一百零二",      10102)>]
[<InlineData(                    "二万三千五百六十四",      23564)>]
[<InlineData(                            "八万零一十",      80010)>]
[<InlineData(                                "一十万",     100000)>]
[<InlineData(                            "一十万零一",     100001)>]
[<InlineData(                "三十一万九千三百四十九",     319349)>]
[<InlineData(                                "一百万",    1000000)>]
[<InlineData(                            "一百万零一",    1000001)>]
[<InlineData(                            "两百万零十",    2000010)>]
[<InlineData(                            "六百零三万",    6030000)>]
[<InlineData(                "九百二十万一千六百八十",    9201680)>]
[<InlineData(                                "一千万",   10000000)>]
[<InlineData(                            "一千万零九",   10000009)>]
[<InlineData(                            "两千一百万",   21000000)>]
[<InlineData(            "四千七百六十六万一千零六十",   47661060)>]
[<InlineData(                                  "一亿",  100000000)>]
[<InlineData(                          "二亿零五百万",  205000000)>]
[<InlineData(                          "三亿零七百万",  307000000)>]
[<InlineData(                "四亿六千一百零六万六百",  461060600)>]
[<InlineData(                                "一十亿", 1000000000)>]
[<InlineData(                                "二十亿", 2000000000)>]
[<InlineData(                "二十亿四千九百六十五万", 2049650000)>]
[<InlineData("二十一亿四千七百四十八万三千六百四十七", System.Int32.MaxValue)>]
let ``tryOfSimplifiedChinese returns correct result`` (chinese, expected) =
    let actual = Numeral.tryParseSimplifiedChinese chinese
    Some expected =! actual

[<Theory>]
[<InlineData(                    0, "零")>]
[<InlineData(                    1, "一")>]
[<InlineData(                    2, "两")>]
[<InlineData(                    3, "三")>]
[<InlineData(                    4, "四")>]
[<InlineData(                    5, "五")>]
[<InlineData(                    6, "六")>]
[<InlineData(                    7, "七")>]
[<InlineData(                    8, "八")>]
[<InlineData(                    9, "九")>]
[<InlineData(                   10, "十")>]
[<InlineData(                   11, "十一")>]
[<InlineData(                   12, "十二")>]
[<InlineData(                   13, "十三")>]
[<InlineData(                   14, "十四")>]
[<InlineData(                   15, "十五")>]
[<InlineData(                   16, "十六")>]
[<InlineData(                   17, "十七")>]
[<InlineData(                   18, "十八")>]
[<InlineData(                   19, "十九")>]
[<InlineData(                   20, "二十")>]
[<InlineData(                   21, "二十一")>]
[<InlineData(                   30, "三十")>]
[<InlineData(                   34, "三十四")>]
[<InlineData(                   40, "四十")>]
[<InlineData(                   42, "四十二")>]
[<InlineData(                   50, "五十")>]
[<InlineData(                   58, "五十八")>]
[<InlineData(                   60, "六十")>]
[<InlineData(                   65, "六十五")>]
[<InlineData(                   70, "七十")>]
[<InlineData(                   79, "七十九")>]
[<InlineData(                   80, "八十")>]
[<InlineData(                   86, "八十六")>]
[<InlineData(                   90, "九十")>]
[<InlineData(                   93, "九十三")>]
[<InlineData(                  100, "一百")>]
[<InlineData(                  101, "一百零一")>]
[<InlineData(                  110, "一百一十")>]
[<InlineData(                  114, "一百一十四")>]
[<InlineData(                  135, "一百三十五")>]
[<InlineData(                  200, "两百")>]
[<InlineData(                  282, "两百八十二")>]
[<InlineData(                  331, "三百三十一")>]
[<InlineData(                  407, "四百零七")>]
[<InlineData(                  520, "五百二十")>]
[<InlineData(                  666, "六百六十六")>]
[<InlineData(                  798, "七百九十八")>]
[<InlineData(                  857, "八百五十七")>]
[<InlineData(                  999, "九百九十九")>]
[<InlineData(                 1000, "一千")>]
[<InlineData(                 1001, "一千零一")>]
[<InlineData(                 1010, "一千零一十")>]
[<InlineData(                 1066, "一千零六十六")>]
[<InlineData(                 1337, "一千三百三十七")>]
[<InlineData(                 1984, "一千九百八十四")>]
[<InlineData(                 2015, "两千零一十五")>]
[<InlineData(                 3000, "三千")>]
[<InlineData(                 3297, "三千两百九十七")>]
[<InlineData(                 4080, "四千零八十")>]
[<InlineData(                 5011, "五千零一十一")>]
[<InlineData(                 6025, "六千零二十五")>]
[<InlineData(                 7441, "七千四百四十一")>]
[<InlineData(                 8513, "八千五百一十三")>]
[<InlineData(                 9000, "九千")>]
[<InlineData(                10000, "一万")>]
[<InlineData(                12001, "一万两千零一")>]
[<InlineData(                23456, "二万三千四百五十六")>]
[<InlineData(                32109, "三万两千一百零九")>]
[<InlineData(                40404, "四万零四百零四")>]
[<InlineData(                56789, "五万六千七百八十九")>]
[<InlineData(                60015, "六万零一十五")>]
[<InlineData(                71003, "七万一千零三")>]
[<InlineData(                80522, "八万零五百二十二")>]
[<InlineData(                98765, "九万八千七百六十五")>]
[<InlineData(               100000, "一十万")>]
[<InlineData(               100001, "一十万零一")>]
[<InlineData(               100010, "一十万零一十")>]
[<InlineData(               101010, "一十万一千零一十")>]
[<InlineData(               200000, "二十万")>]
[<InlineData(               321000, "三十二万一千")>]
[<InlineData(               411416, "四十一万一千四百一十六")>]
[<InlineData(               530121, "五十三万零一百二十一")>]
[<InlineData(               600000, "六十万")>]
[<InlineData(               788000, "七十八万八千")>]
[<InlineData(               876540, "八十七万六千五百四十")>]
[<InlineData(               908077, "九十万八千零七十七")>]
[<InlineData(              1000000, "一百万")>]
[<InlineData(              2000002, "两百万零二")>]
[<InlineData(              3040506, "三百零四万零五百零六")>]
[<InlineData(              4321000, "四百三十二万一千")>]
[<InlineData(              5004621, "五百万四千六百二十一")>]
[<InlineData(              6982001, "六百九十八万两千零一")>]
[<InlineData(              7000000, "七百万")>]
[<InlineData(              8000220, "八百万零两百二十")>]
[<InlineData(              9099000, "九百零九万九千")>]
[<InlineData(             10000000, "一千万")>]
[<InlineData(             24000000, "两千四百万")>]
[<InlineData(             39020011, "三千九百零二万零一十一")>]
[<InlineData(             40606100, "四千零六十万六千一百")>]
[<InlineData(             53000000, "五千三百万")>]
[<InlineData(             64000098, "六千四百万零九十八")>]
[<InlineData(             70003190, "七千万三千一百九十")>]
[<InlineData(             80000000, "八千万")>]
[<InlineData(             99000099, "九千九百万零九十九")>]
[<InlineData(            100000000, "一亿")>]
[<InlineData(            209000000, "二亿零九百万")>]
[<InlineData(            398000000, "三亿九千八百万")>]
[<InlineData(            439011000, "四亿三千九百零一万一千")>]
[<InlineData(            560400000, "五亿六千零四十万")>]
[<InlineData(            600010900, "六亿零一万零九百")>]
[<InlineData(            700000000, "七亿")>]
[<InlineData(            800116000, "八亿零一十一万六千")>]
[<InlineData(            900800007, "九亿零八十万零七")>]
[<InlineData(           1000000000, "一十亿")>]
[<InlineData(           2121000000, "二十一亿两千一百万")>]
[<InlineData(System.Int32.MaxValue, "二十一亿四千七百四十八万三千六百四十七")>]
let ``toSimplifiedChinese returns correct result`` (i, expected) =
    let actual = Numeral.toSimplifiedChinese i
    expected =! actual