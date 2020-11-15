main = do
    printTriangle 5

printRow n =
    if n == 0
    then ""
    else "*" ++ (printRow1 (n-1))

printTriangle 0 = return ()
printTriangle n = 
    do
        putStrLn(printRow n)
        printTriangle (n - 1)