main = do
    command <- getLine
    argument <- getLine
    let num = read argument :: Integer
    if command == "add1"
        then
            print(show (add1 num))
        else if command == "remove1"
            then print(show (remove1 num))
            else putStrLn "Wrong command!"
            
add1 x = x + 1
remove1 x = x - 1
