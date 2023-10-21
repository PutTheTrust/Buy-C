interface ButtonProps {
  text: string;
  isOutline: boolean;
}

const Button: React.FC<ButtonProps> = ({ text, isOutline }) => {
  return (
    <button
      className={
        !isOutline
          ? "h-12 bg-black text-white rounded-3xl w-full font-semibold"
          : "h-12 text-black rounded-3xl w-full outline outline-1 font-semibold"
      }
    >
      {text}
    </button>
  );
};

export default Button;
