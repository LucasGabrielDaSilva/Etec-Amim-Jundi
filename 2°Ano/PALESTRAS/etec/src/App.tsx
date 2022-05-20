import "./styles.css";
import { Counter } from "./components/Counter";
import { FormEvent, useState } from "react";

type DataList = {
  id: number;
  name: string;
};

type ListProps = {
  data: DataList[];
};

const ListComponent = ({ data }: ListProps) => (
  <ul>{data && data.map((item, index) => <li key={index}>{item.name}</li>)}</ul>
);

export default function App() {
  const [items, setItems] = useState<DataList[] | []>([]);
  const [text, setSext] = useState("");

  const handleSubmit = (e: FormEvent) => {
    e.preventDefault();

    if (!text) return alert("Preencha o campo");

    const newObj = {
      id: Date.now(),
      name: text
    };

    setItems((oldState) => [...oldState, newObj]);
    setSext("");
  };

  return (
    <div className="App">
      <Counter />
      <ListComponent data={items} />

      <div>
        <form onSubmit={handleSubmit} className="container">
          <label htmlFor="new-todo">O que precisa ser feito?</label>
          <input
            id="new-todo"
            value={text}
            onChange={(e) => setSext(e.currentTarget.value)}
          />
          <button className="primary">Adicionar #{items.length + 1}</button>
        </form>
      </div>
    </div>
  );
}
