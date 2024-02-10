import { useState } from "react";

export function TryParse(str: string | null) {
  if (str == null) return null;
  try {
    return JSON.parse(str);
  } catch (e) {
    return null;
  }
}

export const useLocalStorage = () => {
  const [value, setValue] = useState<string | null>(null);

  const setItem = (key: string, value: string) => {
    localStorage.setItem(key, value);
    setValue(value);
  };

  const getItem = (key: string) => {
    const value = localStorage.getItem(key);
    setValue(value);
    return value;
  };

  const removeItem = (key: string) => {
    localStorage.removeItem(key);
    setValue(null);
  };

  return { value, setItem, getItem, removeItem };
};
