local TheInput = GLOBAL.TheInput
local KEY_P = GLOBAL.KEY_P
local IsPaused = GLOBAL.IsPaused

TheInput:AddKeyDownHandler(KEY_P, function()
  if TheInput:IsKeyDown(KEY_P) then
    if not IsPaused() then
      GLOBAL.SetPause(true)
    else
      GLOBAL.SetPause(false)
    end
  end
end)