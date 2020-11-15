main = do
    number1 <- getLine
    number2 <- getLine
    number3 <- getLine
    let num1 = read number1 :: Integer
    let num2 = read number2 :: Integer
    let num3 = read number3 :: Integer
    print(show (biggestOf num1 num2 num3))

biggestOf a b c = 
                if a > b
                then if a > c
                    then a
                    else c
                else if b > c
                    then b
                    else c