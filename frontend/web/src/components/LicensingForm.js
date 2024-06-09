/* src/components/LicensingForm.js */

import React from 'react';
import InputField from '../components/InputField';
import Button from '../components/Button';
import { getStatusIcon } from '../utils/helper';

const LicensingForm = ({
  formData,
  handleInputChange,
  stateLicenseStatus,
  handleSubmit,
}) => (
  <form onSubmit={handleSubmit}>
    <p className="org-info">Organization Information</p>
    <p className="form-subtitle">Licensing and Regulatory Compliance</p>
    <div className="input-pair">
      <div className="license-check">
        <InputField
          type="text"
          placeholder="State License Number (ABC12345678)"
          name="stateLicense"
          value={formData.stateLicense}
          onChange={handleInputChange}
        />
        <div className="license-status">
          {getStatusIcon(stateLicenseStatus)}
        </div>
      </div>
    </div>
    <Button type="submit" className="button">
      Continue
    </Button>
  </form>
);

export default LicensingForm;
