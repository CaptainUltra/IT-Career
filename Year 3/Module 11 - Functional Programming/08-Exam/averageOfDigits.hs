digs :: Integral x => x -> [x]
digs 0 = []
digs x = digs (x `div` 10) ++ [x `mod` 10]

main = do
    input <- getLine
    let number = read input :: Integer
    let a = digs number
    let b = fromIntegral (sum a)
    let c = fromIntegral (length a)
    let d = round (b / c)
    putStrLn(show d)