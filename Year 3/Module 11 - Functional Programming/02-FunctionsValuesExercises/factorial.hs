factorial n = 
    if n == 1 || n == 0
    then 1
    else n * factorial (n - 1)

main = do
    putStrLn(show(factorial 5))