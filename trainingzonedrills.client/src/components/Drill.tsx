import React from "react";

interface DrillProps {
    //imageUrl: string;
    name: string;
    description: string;
}

export const Drill: React.FC<DrillProps> = ({
    name,
    description,
}) => {
    return (
        <div className="card bg-base-100 w-60 shadow-xl">
            <figure>
                <img
                    src="https://sambasoccerschools.com/wp-content/uploads/2021/03/rondo-soccer.jpg"
                    alt="Rondo"
                />
            </figure>
            <div className="card-body">
                <h2 className="card-title">{name}</h2>
                <p>{description}</p>
                <div className="card-actions justify-end">
                    <button className="btn btn-primary text-white">See more</button>
                </div>
            </div>
        </div>
    );
};
