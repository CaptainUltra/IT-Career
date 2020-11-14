showPlus x s =
    if null s 
    then show x
    else "(" ++ (show x) ++ "+" ++ s ++ ")"

generateMathExpression list = foldr showPlus "" list

main = do
    putStrLn(show(generateMathExpression [1,2,3,4,5]))