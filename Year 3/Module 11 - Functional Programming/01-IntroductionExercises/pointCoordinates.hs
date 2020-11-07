main = do
    --Opposite points of the rectangle
    pointAXLine <- getLine
    pointAYLine <- getLine
    pointBXLine <- getLine
    pointBYLine <- getLine
    --Point to check
    pointCXLine <- getLine
    pointCYLine <- getLine

    --Convert into interger
    let pointAX = read pointAXLine :: Integer
    let pointAY = read pointAYLine :: Integer
    let pointBX = read pointBXLine :: Integer
    let pointBY = read pointBYLine :: Integer
    let pointCX = read pointCXLine :: Integer
    let pointCY = read pointCYLine :: Integer
    
    if(pointCX >= pointAX && pointCX <= pointBX)
    then if (pointCY >= pointAY && pointCY <= pointBY)
        then putStrLn "INSIDE"
        else putStrLn "OUTSIDE"
    else putStrLn "OUTSIDE"