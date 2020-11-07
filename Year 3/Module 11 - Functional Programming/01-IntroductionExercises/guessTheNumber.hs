main = do
    line <- getLine
    let number = read line :: Integer
    guessingFunction number

guessingFunction number = do
    line <- getLine
    let numberToTry = read line :: Integer
    if numberToTry > number
    then do 
        putStrLn "Too high!"
        guessingFunction number
    else if numberToTry < number
    then do
        putStrLn "Too low!"
        guessingFunction number
    else putStrLn "You win!"