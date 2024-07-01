// tailwind.config.js

/** @type {import('tailwindcss').Config} */
import daisyui from "daisyui";

export default {
  content: ["./src/**/*.{js,jsx,ts,tsx}"],
  theme: {
    extend: {
      colors: {
        primary: "#00b6ff",
        secondary: "#007735",
        accent: "#ff0000",
        neutral: "#28271c",
        info: "#007fd4",
        success: "#00c337",
        warning: "#fde047",
        error: "#dc2626",
      },
    },
  },
  plugins: [daisyui],
  daisyui: {
    themes: [
      {
        mytheme: {
          primary: "#00b6ff",
          secondary: "#007735",
          accent: "#ff0000",
          neutral: "#28271c",
          info: "#007fd4",
          success: "#00c337",
          warning: "#fde047",
          error: "#dc2626",
        },
      },
    ],
  },
};
