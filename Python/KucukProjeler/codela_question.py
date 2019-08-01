def solution(brackets):
  result = 0
  stack = 0
  for i in range(len(brackets)):
    if brackets[i] == "(":
      stack += 1
    elif brackets[i] == ")" and stack != 0:
      stack -=1
      result += 1
      i += 1
      if brackets[i] != ")" and stack != 0:
        stack = 0
  
  return result

print(solution("(((())()(()((()))))"))
