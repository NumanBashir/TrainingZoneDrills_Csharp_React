import React from "react";

interface DrillProps {
    imgUrl: string;
    name: string;
    description: string;
}

export const Drill: React.FC<DrillProps> = ({
    name,
    description,
    imgUrl,
}) => {
    return (
        <div className="card bg-base-100 w-60 shadow-xl">
            <figure>
                <img
                    src={imgUrl}
                    alt={name}
                    className="object-cover h-48 w-96"
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
