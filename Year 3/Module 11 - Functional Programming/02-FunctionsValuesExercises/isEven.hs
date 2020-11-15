main = do
    input <- getLine
    let num = read input :: Integer
    print(show (isEven num))

isEven n = 
        if n `mod` 2 == 0
        then True
        else False