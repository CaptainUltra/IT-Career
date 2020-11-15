main = do
    input <- getLine
    let num = read input :: Integer
    print(show(logOfN num))

logOfN n =
    if n == 1
        then 0
        else 1 + logOfN (n `div` 2)