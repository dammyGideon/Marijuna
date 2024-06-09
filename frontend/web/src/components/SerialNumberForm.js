/* src/components/SerialNumberForm.js */

// Custom Component Block
import { Button, InputField } from './index';

const SerialNumberForm = ({ formData, handleInputChange, handleSubmit }) => (
  <form onSubmit={handleSubmit}>
    <label className="form-subtitle">Enter your device's Serial Number.</label>
    <InputField
      type="text"
      placeholder="Serial Number"
      name="serialNumber"
      value={formData.serialNumber}
      onChange={handleInputChange}
      required
    />
    <Button type="submit" className="button">
      Continue
    </Button>
  </form>
);

export default SerialNumberForm;
