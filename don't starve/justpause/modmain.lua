local TheInput = GLOBAL.TheInput
local KEY_P = GLOBAL.KEY_P
local IsPaused = GLOBAL.IsPaused

GLOBAL.jp_key = GetModConfigData("jp_key")

TheInput:AddKeyDownHandler(GLOBAL.jp_key or KEY_P, function()
  if TheInput:IsKeyDown(GLOBAL.jp_key) then
    if not IsPaused() then
      GLOBAL.SetPause(true)
    else
      GLOBAL.SetPause(false)
    end
  end
end)