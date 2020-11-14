duplicate list = foldr (\ x xs -> x : x : xs) [] list
--duplicate list = foldl (\ xs x -> x : x : xs) [] list

main = do
    putStrLn(show(duplicate [1,2,3,4]))


{- duplicate a b = zip a b

main = do
    putStrLn(show(duplicate [1,2,3,4] [1,2,3,4])) -}