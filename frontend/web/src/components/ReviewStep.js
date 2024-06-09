/* src/components/ReviewStep.js */
// Package Block
import { Divider } from 'antd';

// Custom Components and function
import { InputField, Button } from '../components';
import {
  CustomCounties,
  CustomOrganizationType,
  CustomStates,
} from '../utils/constant';

const ReviewStep = ({
  formData,
  handleInputChange,
  handleSubmit,
  setOrganizationType,
}) => {
  return (
    <form onSubmit={handleSubmit}>
      <h3 className="form-subtitle">Review Your Information</h3>
      <p className="form-subtitle">
        Please review submitted onboarding information. If you need to edit,
        simply click on the field and edit.
      </p>
      <Divider>Basic Information</Divider>
      <div className="input-pair">
        <select
          value={formData.roleId}
          onChange={(e) => setOrganizationType(e.target.value)}
          required
          className="select-field"
          name="roleId"
        >
          <option value="" disabled>
            Select...
          </option>
          {CustomOrganizationType.map(({ value, name }) => (
            <option value={value}>{name}</option>
          ))}
        </select>

        <select
          value={formData.countiesId}
          onChange={handleInputChange}
          required
          className="select-field"
          placeholder="Select..."
          name="countiesId"
        >
          <option value="" disabled>
            Select...
          </option>
          {CustomCounties?.map((county, index) => (
            <option key={index} value={county?.id}>
              {county?.name}
            </option>
          ))}
        </select>
      </div>
      <div className="input-pair">
        <InputField
          type="text"
          placeholder="Serial Number"
          value={formData?.serialNumber}
          onChange={handleInputChange}
          name={'serialNumber'}
        />{' '}
        <InputField
          type="text"
          placeholder="State License Number (ABC12345678)"
          value={formData?.stateLicense}
          onChange={handleInputChange}
          name="stateLicense"
        />
      </div>
      <Divider>Organization Representative Information</Divider>
      <div className="input-pair">
        <InputField
          type="text"
          placeholder="First Name"
          value={formData?.firstName}
          onChange={handleInputChange}
          name="firstName"
        />
        <InputField
          type="text"
          placeholder="Last Name"
          value={formData?.lastName}
          onChange={handleInputChange}
          name="lastName"
        />
      </div>
      <div className="input-pair">
        <InputField
          type="tel"
          placeholder="Phone Number"
          value={formData?.phoneNumber}
          onChange={handleInputChange}
          name="phoneNumber"
        />
        <InputField
          type="email"
          placeholder="Email"
          value={formData?.email}
          onChange={handleInputChange}
          name="email"
        />
      </div>
      <div className="input-pair">
        <InputField
          type="text"
          placeholder="Address"
          value={formData?.streetAddress}
          onChange={handleInputChange}
          name="streetAddress"
        />
        <InputField
          type="text"
          placeholder="City"
          value={formData?.usersCity}
          onChange={handleInputChange}
          name="usersCity"
        />
      </div>
      <div className="input-pair">
        <select
          name="usersState"
          value={formData.usersState}
          onChange={handleInputChange}
          required
          className="select-field"
        >
          <option value="">Select State</option>
          {CustomStates?.map((state, index) => (
            <option key={index} value={state?.id}>
              {state?.name}
            </option>
          ))}
        </select>
        <InputField
          type="text"
          placeholder="Zip Code"
          value={formData?.userZipCode}
          onChange={handleInputChange}
          name="userZipCode"
        />
      </div>
      <Divider>Business Details</Divider>
      <div className="input-pair">
        <InputField
          type="text"
          placeholder="Legal Business Name"
          value={formData?.businessName}
          onChange={handleInputChange}
          name="businessName"
        />
        <InputField
          type="text"
          placeholder="EIN # (12-1234567)"
          value={formData?.businessEIN}
          onChange={handleInputChange}
          name="businessEIN"
        />
      </div>
      <div className="input-pair">
        <InputField
          type="email"
          placeholder="Email"
          value={formData?.businessEmail}
          onChange={handleInputChange}
          name="businessEmail"
        />
        <InputField
          type="tel"
          placeholder="Phone"
          value={formData.businessContact}
          onChange={handleInputChange}
          name="businessContact"
        />
      </div>
      <div className="input-pair">
        <InputField
          type="text"
          placeholder="Address"
          value={formData.businessAddress}
          onChange={handleInputChange}
          name="businessAddress"
        />
        <InputField
          type="text"
          placeholder="City"
          value={formData.businessCity}
          onChange={handleInputChange}
          name="businessCity"
        />
      </div>
      <div className="input-pair">
        <select
          name="businessState"
          value={formData.businessState}
          onChange={handleInputChange}
          required
          className="select-field"
        >
          <option value="">Select State</option>
          {CustomStates?.map((state, index) => (
            <option key={index} value={state?.id}>
              {state?.name}
            </option>
          ))}
        </select>
        <InputField
          type="text"
          placeholder="Zip Code"
          value={formData.businessZipCode}
          onChange={handleInputChange}
          name="businessZipCode"
        />
      </div>
      <Divider>Password Verification</Divider>
      <div className="input-pair">
        <InputField
          type="text"
          placeholder="Password"
          value={formData?.password}
          onChange={handleInputChange}
          name="password"
        />{' '}
        <InputField
          type="text"
          placeholder="Confirm Password"
          value={formData?.confirmPassword}
          onChange={handleInputChange}
          name="confirmPassword"
        />
      </div>
      <div className="button-group">
        <Button type="submit" className="button">
          Complete Onboarding
        </Button>
      </div>
    </form>
  );
};

export default ReviewStep;
