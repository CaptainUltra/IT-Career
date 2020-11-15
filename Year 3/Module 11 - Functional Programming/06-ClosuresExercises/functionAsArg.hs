add1 = (\ a -> a + 1)
remove1 = (\ a -> a - 1)

execute a = (\ func -> func a)

main = do
    putStrLn(show(execute 5 add1))
    putStrLn(show(execute 5 remove1))