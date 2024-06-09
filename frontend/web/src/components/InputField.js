// src/components/InputField.js
const InputField = ({
  type,
  placeholder,
  name,
  value,
  onChange,
  disabled,
  required,
  pattern,
}) => {
  return (
    <input
      type={type}
      placeholder={placeholder}
      name={name}
      value={value}
      onChange={onChange}
      required={required}
      pattern={pattern}
      disabled={disabled}
      className="input-field"
    />
  );
};

export default InputField;
