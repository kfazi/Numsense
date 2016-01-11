﻿module Ploeh.Numsense.SimplifiedFinancialChineseExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                    "零",          0)>]
[<InlineData(                                   " 零",          0)>]
[<InlineData(                                   "零 ",          0)>]
[<InlineData(                                "  零  ",          0)>]
[<InlineData(                                 " 零\t",          0)>]
[<InlineData(                                    "壹",          1)>]
[<InlineData(                                    "贰",          2)>]
[<InlineData(                                   " 两",          2)>]
[<InlineData(                                    "叁",          3)>]
[<InlineData(                                  "叁  ",          3)>]
[<InlineData(                                    "肆",          4)>]
[<InlineData(                                 "  肆 ",          4)>]
[<InlineData(                                    "伍",          5)>]
[<InlineData(                                    "陆",          6)>]
[<InlineData(                                "  陆  ",          6)>]
[<InlineData(                                    "柒",          7)>]
[<InlineData(                                "    柒",          7)>]
[<InlineData(                                    "捌",          8)>]
[<InlineData(                                    "玖",          9)>]
[<InlineData(                                  "玖  ",          9)>]
[<InlineData(                                    "拾",         10)>]
[<InlineData(                                  "拾壹",         11)>]
[<InlineData(                                  "拾贰",         12)>]
[<InlineData(                                  "拾叁",         13)>]
[<InlineData(                                  "拾肆",         14)>]
[<InlineData(                                  "拾伍",         15)>]
[<InlineData(                                  "拾陆",         16)>]
[<InlineData(                                  "拾柒",         17)>]
[<InlineData(                                  "拾捌",         18)>]
[<InlineData(                                  "拾玖",         19)>]
[<InlineData(                                  "贰拾",         20)>]
[<InlineData(                                "贰拾壹",         21)>]
[<InlineData(                                  "叁拾",         30)>]
[<InlineData(                                "叁拾肆",         34)>]
[<InlineData(                                "叁拾捌",         38)>]
[<InlineData(                                  "肆拾",         40)>]
[<InlineData(                                "肆拾壹",         41)>]
[<InlineData(                                "肆拾肆",         44)>]
[<InlineData(                                  "伍拾",         50)>]
[<InlineData(                                "伍拾柒",         57)>]
[<InlineData(                                  "陆拾",         60)>]
[<InlineData(                                "陆拾伍",         65)>]
[<InlineData(                                  "柒拾",         70)>]
[<InlineData(                                "柒拾柒",         77)>]
[<InlineData(                                "柒拾玖",         79)>]
[<InlineData(                                  "捌拾",         80)>]
[<InlineData(                                "捌拾陆",         86)>]
[<InlineData(                                  "玖拾",         90)>]
[<InlineData(                                "玖拾叁",         93)>]
[<InlineData(                                  "壹佰",        100)>]
[<InlineData(                              "壹佰零壹",        101)>]
[<InlineData(                                  "两佰",        200)>]
[<InlineData(                            "两佰叁拾柒",        237)>]
[<InlineData(                            "叁佰柒拾伍",        375)>]
[<InlineData(                              "肆佰玖拾",        490)>]
[<InlineData(                            "伍佰陆拾叁",        563)>]
[<InlineData(                            "陆佰壹拾捌",        618)>]
[<InlineData(                            "柒佰柒拾柒",        777)>]
[<InlineData(                              "捌佰零伍",        805)>]
[<InlineData(                              "捌佰零陆",        806)>]
[<InlineData(                              "捌佰零柒",        807)>]
[<InlineData(                            "玖佰伍拾玖",        959)>]
[<InlineData(                                  "壹仟",       1000)>]
[<InlineData(                              "壹仟零壹",       1001)>]
[<InlineData(                              "壹仟零贰",       1002)>]
[<InlineData(                            "壹仟陆拾肆",       1064)>]
[<InlineData(                                  "两仟",       2000)>]
[<InlineData(                        "捌仟柒佰贰拾壹",       8721)>]
[<InlineData(                        "玖仟壹佰贰拾叁",       9123)>]
[<InlineData(                                  "壹万",      10000)>]
[<InlineData(                        "壹万零壹佰零壹",      10101)>]
[<InlineData(                        "壹万零壹佰零贰",      10102)>]
[<InlineData(                    "贰万叁仟伍佰陆拾肆",      23564)>]
[<InlineData(                            "捌万零壹拾",      80010)>]
[<InlineData(                                "壹拾万",     100000)>]
[<InlineData(                            "壹拾万零壹",     100001)>]
[<InlineData(                "叁拾壹万玖仟叁佰肆拾玖",     319349)>]
[<InlineData(                                "壹佰万",    1000000)>]
[<InlineData(                            "壹佰万零壹",    1000001)>]
[<InlineData(                            "两佰万零拾",    2000010)>]
[<InlineData(                            "陆佰零叁万",    6030000)>]
[<InlineData(                "玖佰贰拾万壹仟陆佰捌拾",    9201680)>]
[<InlineData(                                "壹仟万",   10000000)>]
[<InlineData(                            "壹仟万零玖",   10000009)>]
[<InlineData(                            "两仟壹佰万",   21000000)>]
[<InlineData(            "肆仟柒佰陆拾陆万壹仟零陆拾",   47661060)>]
[<InlineData(                                  "壹亿",  100000000)>]
[<InlineData(                          "贰亿零伍佰万",  205000000)>]
[<InlineData(                          "叁亿零柒佰万",  307000000)>]
[<InlineData(                "肆亿陆仟壹佰零陆万陆佰",  461060600)>]
[<InlineData(                                "壹拾亿", 1000000000)>]
[<InlineData(                                "贰拾亿", 2000000000)>]
[<InlineData(                "贰拾亿肆仟玖佰陆拾伍万", 2049650000)>]
[<InlineData("贰拾壹亿肆仟柒佰肆拾捌万叁仟陆佰肆拾柒", System.Int32.MaxValue)>]
let ``tryOfSimplifiedFinancialChinese returns correct result`` (chinese, expected) =
    let actual = Numeral.tryParseSimplifiedFinancialChinese chinese
    Some expected =! actual

[<Theory>]
[<InlineData(                    0, "零")>]
[<InlineData(                    1, "壹")>]
[<InlineData(                    2, "两")>]
[<InlineData(                    3, "叁")>]
[<InlineData(                    4, "肆")>]
[<InlineData(                    5, "伍")>]
[<InlineData(                    6, "陆")>]
[<InlineData(                    7, "柒")>]
[<InlineData(                    8, "捌")>]
[<InlineData(                    9, "玖")>]
[<InlineData(                   10, "拾")>]
[<InlineData(                   11, "拾壹")>]
[<InlineData(                   12, "拾贰")>]
[<InlineData(                   13, "拾叁")>]
[<InlineData(                   14, "拾肆")>]
[<InlineData(                   15, "拾伍")>]
[<InlineData(                   16, "拾陆")>]
[<InlineData(                   17, "拾柒")>]
[<InlineData(                   18, "拾捌")>]
[<InlineData(                   19, "拾玖")>]
[<InlineData(                   20, "贰拾")>]
[<InlineData(                   21, "贰拾壹")>]
[<InlineData(                   30, "叁拾")>]
[<InlineData(                   34, "叁拾肆")>]
[<InlineData(                   40, "肆拾")>]
[<InlineData(                   42, "肆拾贰")>]
[<InlineData(                   50, "伍拾")>]
[<InlineData(                   58, "伍拾捌")>]
[<InlineData(                   60, "陆拾")>]
[<InlineData(                   65, "陆拾伍")>]
[<InlineData(                   70, "柒拾")>]
[<InlineData(                   79, "柒拾玖")>]
[<InlineData(                   80, "捌拾")>]
[<InlineData(                   86, "捌拾陆")>]
[<InlineData(                   90, "玖拾")>]
[<InlineData(                   93, "玖拾叁")>]
[<InlineData(                  100, "壹佰")>]
[<InlineData(                  101, "壹佰零壹")>]
[<InlineData(                  110, "壹佰壹拾")>]
[<InlineData(                  114, "壹佰壹拾肆")>]
[<InlineData(                  135, "壹佰叁拾伍")>]
[<InlineData(                  200, "两佰")>]
[<InlineData(                  282, "两佰捌拾贰")>]
[<InlineData(                  331, "叁佰叁拾壹")>]
[<InlineData(                  407, "肆佰零柒")>]
[<InlineData(                  520, "伍佰贰拾")>]
[<InlineData(                  666, "陆佰陆拾陆")>]
[<InlineData(                  798, "柒佰玖拾捌")>]
[<InlineData(                  857, "捌佰伍拾柒")>]
[<InlineData(                  999, "玖佰玖拾玖")>]
[<InlineData(                 1000, "壹仟")>]
[<InlineData(                 1001, "壹仟零壹")>]
[<InlineData(                 1010, "壹仟零壹拾")>]
[<InlineData(                 1066, "壹仟零陆拾陆")>]
[<InlineData(                 1337, "壹仟叁佰叁拾柒")>]
[<InlineData(                 1984, "壹仟玖佰捌拾肆")>]
[<InlineData(                 2015, "两仟零壹拾伍")>]
[<InlineData(                 3000, "叁仟")>]
[<InlineData(                 3297, "叁仟两佰玖拾柒")>]
[<InlineData(                 4080, "肆仟零捌拾")>]
[<InlineData(                 5011, "伍仟零壹拾壹")>]
[<InlineData(                 6025, "陆仟零贰拾伍")>]
[<InlineData(                 7441, "柒仟肆佰肆拾壹")>]
[<InlineData(                 8513, "捌仟伍佰壹拾叁")>]
[<InlineData(                 9000, "玖仟")>]
[<InlineData(                10000, "壹万")>]
[<InlineData(                12001, "壹万两仟零壹")>]
[<InlineData(                23456, "贰万叁仟肆佰伍拾陆")>]
[<InlineData(                32109, "叁万两仟壹佰零玖")>]
[<InlineData(                40404, "肆万零肆佰零肆")>]
[<InlineData(                56789, "伍万陆仟柒佰捌拾玖")>]
[<InlineData(                60015, "陆万零壹拾伍")>]
[<InlineData(                71003, "柒万壹仟零叁")>]
[<InlineData(                80522, "捌万零伍佰贰拾贰")>]
[<InlineData(                98765, "玖万捌仟柒佰陆拾伍")>]
[<InlineData(               100000, "壹拾万")>]
[<InlineData(               100001, "壹拾万零壹")>]
[<InlineData(               100010, "壹拾万零壹拾")>]
[<InlineData(               101010, "壹拾万壹仟零壹拾")>]
[<InlineData(               200000, "贰拾万")>]
[<InlineData(               321000, "叁拾贰万壹仟")>]
[<InlineData(               411416, "肆拾壹万壹仟肆佰壹拾陆")>]
[<InlineData(               530121, "伍拾叁万零壹佰贰拾壹")>]
[<InlineData(               600000, "陆拾万")>]
[<InlineData(               788000, "柒拾捌万捌仟")>]
[<InlineData(               876540, "捌拾柒万陆仟伍佰肆拾")>]
[<InlineData(               908077, "玖拾万捌仟零柒拾柒")>]
[<InlineData(              1000000, "壹佰万")>]
[<InlineData(              2000002, "两佰万零贰")>]
[<InlineData(              3040506, "叁佰零肆万零伍佰零陆")>]
[<InlineData(              4321000, "肆佰叁拾贰万壹仟")>]
[<InlineData(              5004621, "伍佰万肆仟陆佰贰拾壹")>]
[<InlineData(              6982001, "陆佰玖拾捌万两仟零壹")>]
[<InlineData(              7000000, "柒佰万")>]
[<InlineData(              8000220, "捌佰万零两佰贰拾")>]
[<InlineData(              9099000, "玖佰零玖万玖仟")>]
[<InlineData(             10000000, "壹仟万")>]
[<InlineData(             24000000, "两仟肆佰万")>]
[<InlineData(             39020011, "叁仟玖佰零贰万零壹拾壹")>]
[<InlineData(             40606100, "肆仟零陆拾万陆仟壹佰")>]
[<InlineData(             53000000, "伍仟叁佰万")>]
[<InlineData(             64000098, "陆仟肆佰万零玖拾捌")>]
[<InlineData(             70003190, "柒仟万叁仟壹佰玖拾")>]
[<InlineData(             80000000, "捌仟万")>]
[<InlineData(             99000099, "玖仟玖佰万零玖拾玖")>]
[<InlineData(            100000000, "壹亿")>]
[<InlineData(            209000000, "贰亿零玖佰万")>]
[<InlineData(            398000000, "叁亿玖仟捌佰万")>]
[<InlineData(            439011000, "肆亿叁仟玖佰零壹万壹仟")>]
[<InlineData(            560400000, "伍亿陆仟零肆拾万")>]
[<InlineData(            600010900, "陆亿零壹万零玖佰")>]
[<InlineData(            700000000, "柒亿")>]
[<InlineData(            800116000, "捌亿零壹拾壹万陆仟")>]
[<InlineData(            900800007, "玖亿零捌拾万零柒")>]
[<InlineData(           1000000000, "壹拾亿")>]
[<InlineData(           2121000000, "贰拾壹亿两仟壹佰万")>]
[<InlineData(System.Int32.MaxValue, "贰拾壹亿肆仟柒佰肆拾捌万叁仟陆佰肆拾柒")>]
let ``toSimplifiedFinancialChinese returns correct result`` (i, expected) =
    let actual = Numeral.toSimplifiedFinancialChinese i
    expected =! actual