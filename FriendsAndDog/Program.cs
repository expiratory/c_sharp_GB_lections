﻿int count = 0;
int distance = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int friend = 2;

while(distance > 10)
{
    if(friend == 1)
    {
        int time = distance/(first_friend_speed + dog_speed);
        friend = 2;
        distance = distance - (first_friend_speed + second_friend_speed)*time;
        count = count + 1;
    }
    
    if(friend == 2)
    {
        int time = distance/(second_friend_speed + dog_speed);
        friend = 1;
        distance = distance - (first_friend_speed + second_friend_speed)*time;
        count = count + 1;
    }
}

    Console.Write("Собака пробежит ");
    Console.Write(count);
    Console.WriteLine(" раз");
