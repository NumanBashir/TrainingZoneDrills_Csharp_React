import React from "react";
import "./App.css";
import { Drill } from "./components/Drill";

function App() {
  return (
    <>
      <div className="pt-4 flex flex-col justify-center items-center">
        <h1 className="text-4xl font-bold">Welcome To TrainingZone!</h1>
        <p className="text-lg mt-2">
          The Worlds Greatest Football Training Drills Platform
        </p>
      </div>
      <div className="flex justify-center p-4">
        <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6">
          <Drill />
          <Drill />
          <Drill />
          <Drill />
          <Drill />
        </div>
      </div>
    </>
  );
}

export default App;
