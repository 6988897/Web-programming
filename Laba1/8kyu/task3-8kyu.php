<?php
// Задание 3 - Дополните функцию вычисления суммы квадратов так, 
  //чтобы она возводила в квадрат каждое переданное ей число, а затем суммировала результаты.
  function square_sum($numbers) : int {
    $sum=0;
    for ($i = 0; $i < count($numbers); $i++) {
          $sum+=$numbers[$i]*$numbers[$i];
      }
    return  $sum;
  
  }
    echo square_sum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);