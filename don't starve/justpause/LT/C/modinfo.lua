name = "只是暂停"
description = "按下按钮暂停游戏(P=默认). 更改mod选项中的按钮. 默认游戏暂停仍然有效."
author = "Ksanter X"
version = "1.22"

forumthread = ""
api_version = 6

icon_atlas = "modicon.xml"
icon = "modicon.tex"

dont_starve_compatible = true
reign_of_giants_compatible = true
shipwrecked_compatible = true
dst_compatible = false
hamlet_compatible = true

configuration_options = {
  {
    name = "jp_key",
    label = "按钮",
    hover = "...",
    options = 
    {
      {description = "F1", data = 282},
      {description = "F2", data = 283},
      {description = "F3", data = 284},
      {description = "F4", data = 285},
      {description = "F5", data = 286},
      {description = "F6", data = 287},
      {description = "F7", data = 288},
      {description = "F8", data = 289},
      {description = "F9", data = 290},
      {description = "F10", data = 291},
      {description = "F11", data = 292},
      {description = "B", data = 98},
      {description = "C", data = 99},
      {description = "F", data = 102},
      {description = "G", data = 103},
      {description = "H", data = 104},
      {description = "I", data = 105},
      {description = "J", data = 106},
      {description = "K", data = 107},
      {description = "L", data = 108},
      {description = "M", data = 109},
      {description = "N", data = 110},
      {description = "O", data = 111},
      {description = "P (默认)", data = 112},
      {description = "R", data = 114},
      {description = "T", data = 116},
      {description = "U", data = 117},
      {description = "V", data = 118},
      {description = "X", data = 120},
      {description = "Y", data = 121},
      {description = "Z", data = 122},
      {description = "SPACE", data = 32},
      {description = "~", data = 96},
      {description = "CAPS LOCk", data = 301}
    },
    default = 112,
  }
}