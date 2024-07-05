import React, { useEffect, useState } from "react";
import "./App.css";
import { Drill } from "./components/Drill";
import axios from "axios";

const App = () => {
    const [drills, setDrills] = useState<Drill[]>([]);

    useEffect(() => {
        axios.get(`https://localhost:7274/api/Drills/`).then((response) => {
            console.log("Drills response:", response.data);
            setDrills(response.data);
        }).catch((error) => {
            console.log("Error fetching drills: ", error);
        })
    }, [])

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
                    {drills.length > 0 ? (
                        drills.map((drill) => (
                            <Drill
                                key={drill.id}
                                imgUrl={drill.imgUrl}
                                name={drill.name}
                                description={drill.description}
                            />
                        ))
                    ) : (
                        <p className="flex justify-center w-full text-lg mt-4 italic">
                            It looks like there were no drills.
                        </p>
                    )}
                    
                </div>
            </div>
        </>
    );
}

export default App;
