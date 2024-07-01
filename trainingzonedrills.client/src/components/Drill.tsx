import React from "react";

export const Drill = () => {
  return (
    <div className="card bg-base-100 w-60 shadow-xl">
      <figure>
        <img
          src="https://sambasoccerschools.com/wp-content/uploads/2021/03/rondo-soccer.jpg"
          alt="Rondo"
        />
      </figure>
      <div className="card-body">
        <h2 className="card-title">Drill 1</h2>
        <p>The famous drill that can make your team the next prime Barcelona</p>
        <div className="card-actions justify-end">
          <button className="btn btn-primary text-white">Buy Now</button>
        </div>
      </div>
    </div>
  );
};
