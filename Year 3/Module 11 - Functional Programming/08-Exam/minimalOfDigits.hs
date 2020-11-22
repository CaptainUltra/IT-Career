digs :: Integral x => x -> [x]
digs 0 = []
digs x = digs (x `div` 10) ++ [x `mod` 10]

main = do
    input <- getLine
    let number = read input :: Integer
    let a = digs number
    putStrLn(show (minimum a))