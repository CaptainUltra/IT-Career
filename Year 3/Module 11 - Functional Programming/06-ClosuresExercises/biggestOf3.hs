biggestOf3 a b = (\c -> max (max a b) c)

main = do
    putStrLn(show(biggestOf3 5 10 20))