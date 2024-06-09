/* src/components/CredentialsForm.js */
// Package Block
import { InputField, Button } from './index';

const CredentialsForm = ({ formData, handleInputChange, handleSubmit }) => (
  <form onSubmit={handleSubmit}>
    <p className="form-subtitle">Account Information</p>
    <p className="form-subtitle">Create your Account.</p>
    <p className="form-subtitle">
      Username: <strong>{formData?.email}</strong>
    </p>
    <div className="input-pair">
      <InputField
        type="password"
        placeholder="Password"
        name="password"
        value={formData.password}
        onChange={handleInputChange}
        required
      />
    </div>
    <div className="input-pair">
      <InputField
        type="password"
        placeholder="Confirm Password"
        name="confirmPassword"
        value={formData.confirmPassword}
        onChange={handleInputChange}
        required
      />
    </div>
    {formData.confirmPassword &&
      formData.password !== formData.confirmPassword && (
        <span className="validation-error">Passwords do not match!</span>
      )}
    <Button type="submit" className={'button'}>
      Submit
    </Button>
  </form>
);

export default CredentialsForm;
