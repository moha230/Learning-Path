#!/bin/zsh 

case "$1" in 
hello|hi)
  echo "hello yourself"
  ;;
goodbye)
  echo "nice to have met you"
  echo "I hope to see you again"
  ;;
*)
 echo "I didnt undertand that"
esac
