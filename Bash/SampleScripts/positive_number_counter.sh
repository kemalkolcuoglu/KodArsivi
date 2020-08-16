#!/usr/bin/bash

# This code get an input from user as max number for counter.
# variable null check and negative number check added.

COUNT=$1
iter_number=0

if [ -z  $COUNT ]; then
  echo "You must enter a number!"
  exit
elif [ $COUNT -le '0' ]; then
  echo "Number Cannot be 0 or less"
  exit
fi

while [ $iter_number -lt $COUNT ]; do
  echo $iter_number
  ((iter_number++))
done

exit
