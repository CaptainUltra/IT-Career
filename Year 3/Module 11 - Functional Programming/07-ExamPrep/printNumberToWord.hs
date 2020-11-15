import System.Exit

main = do
    readInput

readInput = do
    input <- getLine
    if input == "End"
        then exitWith ExitSuccess
        else do
            let number = read input :: Integer
            printNumberWord number
            readInput

printNumberWord num
    | num == 0 = do 
        putStrLn "Zero"            
    | num == 1 = do 
        putStrLn "One"            
    | num == 2 = do
        putStrLn "Two"            
    | num == 3 = do 
        putStrLn "Three"            
    | num == 4 = do 
        putStrLn "Four"            
    | num == 5 = do
        putStrLn "Five"            
    | num == 6 = do 
        putStrLn "Six"            
    | num == 7 = do 
        putStrLn "Seven"            
    | num == 8 = do 
        putStrLn "Eight"            
    | num == 9 = do 
        putStrLn "Nine"            
    | otherwise = do 
        putStrLn "Please only enter single digit positive numbers"
