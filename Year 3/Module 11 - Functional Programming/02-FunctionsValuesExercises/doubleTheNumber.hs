main = do
    number <- getLine
    let num = read number :: Integer
    print(show (dobuleVal num))

dobuleVal val = val + val