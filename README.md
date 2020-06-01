# Enchantment Calculator For Black Desert Online

*A BDO Enchantment Calculatior*

***WORK IN PROGRESS***

### Game

> https://www.blackdesertonline.com/

## Motivation
The motivation of the project was to create a program which would help with the process of 
calculating the average cost of enchantable items in Black Desert Online. With the changing
price of items (items for building fail-stacks, items for repairing, black stones etc.)
calculating the cost can be duffucult at times, so this project was born.

## How The Program Works

The program calculates the enchantment chance percentage using predefined equations created
by Kakao Games. The percentage for enchanting is linear but normally uses split functions for
each enchant. eg:
> x = fail-stacks
```
f(x)={ x = 10  for x <= 41
     { .6 ( x - 41 ) for x >= 42
```
After calculating the percentage the application will calculate the cost to reach the desired
level using the equation:
>X = Fail-stacks   r = repair cost  Eb = Equipment Base Price (enchant)
>B = Black stone cost   F = Fail %
```
X*B +(X/20 *8r) +
```
