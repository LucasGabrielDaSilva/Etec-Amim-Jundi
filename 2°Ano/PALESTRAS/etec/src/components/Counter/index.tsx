import { useState } from "react";

export const Counter = () => {
  const [counter, setCounter] = useState(0);
  return (
    <div className="container">
      <h1>Counter</h1>
      <span>{counter}</span>

      <button
        className="primary"
        onClick={() => setCounter((oldState) => oldState + 1)}
      >
        +
      </button>
      <button onClick={() => setCounter((oldState) => oldState - 1)}>-</button>
    </div>
  );
};
