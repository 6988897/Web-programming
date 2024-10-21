<?php
// Задание 1 - Возьмите массив и удалите из него 
//каждый второй элемент. Всегда сохраняйте первый элемент и 
//начинайте удаление со следующего элемента.
function removeEveryOther($array) {
    $result = [];

    for ($i = 0; $i < count($array); $i += 2) {
        $result[] = $array[$i];
    }
     // 2 Вариант решения
     //for ($i = 0; $i < count($array); $i += 2) {
        //$result[$i] = $array[$i];
    //}
    return $result;
  }
  print_r(removeEveryOther([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]));
   